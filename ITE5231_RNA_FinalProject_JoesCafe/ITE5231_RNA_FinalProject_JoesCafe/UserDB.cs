using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class UserDB {

    public static List<User> GetAllUsers() {
      List<User> allUsers = new List<User>();
      SqlConnection connection = Connection.GetConnection();
      string selectStatement = "SELECT id, username, first_name, last_name, mobile, role FROM DBO.Users";
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

      try {
        connection.Open();
        SqlDataReader userReader = selectCommand.ExecuteReader();
        while (userReader.Read()) {
          User user = new User();
          user.Id = (int)userReader["id"];
          user.Username = (string)userReader["username"];
          user.FirstName = (string)userReader["first_name"];
          user.LastName = (string)userReader["last_name"];
          user.Mobile = (string)userReader["mobile"];
          user.Role = (string)userReader["role"];

          allUsers.Add(user);
        }
      } catch (SqlException ex) {
        Console.WriteLine(ex.ToString());
      } finally {
        connection.Close();
      }

      return allUsers;
    }

    public static bool UsernameExists(string username) {
      SqlConnection connection = Connection.GetConnection();
      string selectStatement = $"SELECT username FROM DBO.Users WHERE username = '{username}'";
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

      try {
        connection.Open();
        SqlDataReader userReader = selectCommand.ExecuteReader();
        if (userReader.HasRows) {
          return true;
        } else {
          return false;
        }
      } catch (SqlException ex) {
        Console.WriteLine(ex.ToString());
      } finally {
        connection.Close();
      }

      return false;
    }

    public static List<UserWithLogin> GetAllUsersWithLogin() {
      List<UserWithLogin> allUsersWithLogin = new List<UserWithLogin>();
      SqlConnection connection = Connection.GetConnection();
      string selectStatement = "SELECT u.id, u.username, u.first_name, u.last_name, u.mobile, u.role, l.password FROM DBO.Users as u, DBO.Logins as l where u.id = l.user_id";
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

      try {
        connection.Open();
        SqlDataReader userWithLoginReader = selectCommand.ExecuteReader();
        while (userWithLoginReader.Read()) {
          UserWithLogin userWithLogin = new UserWithLogin();
          userWithLogin.Id = (int)userWithLoginReader["id"];
          userWithLogin.Username = (string)userWithLoginReader["username"];
          userWithLogin.FirstName = (string)userWithLoginReader["first_name"];
          userWithLogin.LastName = (string)userWithLoginReader["last_name"];
          userWithLogin.Mobile = (string)userWithLoginReader["mobile"];
          userWithLogin.Role = (string)userWithLoginReader["role"];
          userWithLogin.Password = (string)userWithLoginReader["password"];

          allUsersWithLogin.Add(userWithLogin);
        }
      } catch (SqlException ex) {
        Console.WriteLine(ex.ToString());
      } finally {
        connection.Close();
      }

      return allUsersWithLogin;
    }

    public static UserWithLogin verifyLogin(string username, string password) {
      List<UserWithLogin> usersWithLogin = GetAllUsersWithLogin();
      foreach (UserWithLogin user in usersWithLogin) {
        if (user.Username.Equals(username) && user.Password.Equals(password)) {
          return user;
        }
      }

      return null;
    }

    public static User GetUser(int userID) {
      SqlConnection connection = Connection.GetConnection();
      string selectStatement = "SELECT id, first_name, last_name, mobile, role FROM DBO.Users WHERE id = @UserID";
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
      selectCommand.Parameters.AddWithValue("@UserID", userID);

      try {
        connection.Open();
        SqlDataReader userReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
        if (userReader.Read()) {
          User user = new User();
          user.Id = (int)userReader["id"];
          user.FirstName = (string)userReader["first_name"];
          user.LastName = (string)userReader["last_name"];
          user.Mobile = (string)userReader["mobile"];
          user.Role = (string)userReader["role"];
          return user;
        } else {
          return null;
        }
      } catch (SqlException ex) {
        throw ex;
      } finally {
        connection.Close();
      }
    }

    public static int AddCustomerUser(UserWithLogin userWithLogin) {
      SqlConnection connection = Connection.GetConnection();
      SqlTransaction sqlTransaction = null;
      string insertUsersStatement =
          "INSERT DBO.Users (username, first_name, last_name, email, mobile, role) " +
          "VALUES (@Username, @FirstName, @LastName, @Email, @Mobile, @Role)";


      try {
        connection.Open();
        sqlTransaction = connection.BeginTransaction();

        SqlCommand insertUserCommand = new SqlCommand(insertUsersStatement, connection, sqlTransaction);
        insertUserCommand.Parameters.AddWithValue("@Username", userWithLogin.Username);
        insertUserCommand.Parameters.AddWithValue("@FirstName", userWithLogin.FirstName);
        insertUserCommand.Parameters.AddWithValue("@LastName", userWithLogin.LastName);
        insertUserCommand.Parameters.AddWithValue("@Email", userWithLogin.Email);
        insertUserCommand.Parameters.AddWithValue("@Mobile", userWithLogin.Mobile);
        insertUserCommand.Parameters.AddWithValue("@Role", userWithLogin.Role);
        insertUserCommand.ExecuteNonQuery();

        string selectStatement = "SELECT IDENT_CURRENT('DBO.Users') FROM DBO.Users";
        SqlCommand selectCommand = new SqlCommand(selectStatement, connection, sqlTransaction);
        int userID = Convert.ToInt32(selectCommand.ExecuteScalar());

        string insertLoginStatement = "INSERT DBO.Logins (user_id, password) VALUES (@UserId, @Password)";
        SqlCommand insertLoginCommand = new SqlCommand(insertLoginStatement, connection, sqlTransaction);
        insertLoginCommand.Parameters.AddWithValue("@UserId", userID);
        insertLoginCommand.Parameters.AddWithValue("@Password", userWithLogin.Password);
        insertLoginCommand.ExecuteNonQuery();

        sqlTransaction.Commit();
        return userID;
      } catch (SqlException ex) {
        sqlTransaction.Rollback();
        return 0;
      } finally {
        connection.Close();
      }
    }
  }
}
