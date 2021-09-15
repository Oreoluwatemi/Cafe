using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class ProductDB {
    public static List<Product> GetAllProducts() {
      List<Product> allProducts = new List<Product>();
      SqlConnection connection = Connection.GetConnection();
      string selectStatement = "SELECT id, name, description, price, imagetype, product_image FROM DBO.Products";
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

      try {
        connection.Open();
        SqlDataReader productReader = selectCommand.ExecuteReader();
        while (productReader.Read()) {
          Product product = new Product();
          product.Id = (int)productReader["id"];
          product.Name = (string)productReader["name"];
          product.Description = (string)productReader["description"];
          product.Price = Convert.ToDouble((decimal)productReader["price"]);
          product.ImageType = (string)productReader["imagetype"];

          byte[] imageBytes = (byte[])productReader["product_image"];
          BitmapImage bmpImage = new BitmapImage();
          MemoryStream msImageStream = new MemoryStream();
          msImageStream.Write(imageBytes, 0, imageBytes.Length);

          Bitmap bitmap = new Bitmap(msImageStream);
          product.ProductImage = bitmap;

          allProducts.Add(product);
        }
      } catch (SqlException ex) {
        throw ex;
      } finally {
        connection.Close();
      }

      return allProducts;
    }

    public static Product GetProduct(int productId) {
      string selectStatement = $"SELECT id, name, description, price, imagetype, product_image " +
        $"FROM DBO.Products WHERE id = {productId}";
      SqlConnection connection = Connection.GetConnection();
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

      try {
        connection.Open();
        SqlDataReader productReader = selectCommand.ExecuteReader();
        while (productReader.Read()) {
          Product product = new Product();
          product.Id = (int)productReader["id"];
          product.Name = (string)productReader["name"];
          product.Description = (string)productReader["description"];
          product.Price = Convert.ToDouble((decimal)productReader["price"]);
          product.ImageType = (string)productReader["imagetype"];

          byte[] imageBytes = (byte[])productReader["product_image"];
          BitmapImage bmpImage = new BitmapImage();
          MemoryStream msImageStream = new MemoryStream();
          msImageStream.Write(imageBytes, 0, imageBytes.Length);

          Bitmap bitmap = new Bitmap(msImageStream);
          product.ProductImage = bitmap;

          return product;
        }
      } catch (SqlException ex) {
        throw ex;
      } finally {
        connection.Close();
      }

      return null;
    }

    public static Addon GetAddon(int addonId) {
      string selectStatement = $"SELECT id, name, description, price FROM DBO.Addons WHERE id = {addonId}";
      SqlConnection connection = Connection.GetConnection();
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

      try {
        connection.Open();
        SqlDataReader addonReader = selectCommand.ExecuteReader();
        while (addonReader.Read()) {
          Addon addon = new Addon();
          addon.Id = (int)addonReader["id"];
          addon.Name = (string)addonReader["name"];
          addon.Description = (string)addonReader["description"];
          addon.Price = Convert.ToDouble((decimal)addonReader["price"]);

          return addon;
        }
      } catch (SqlException ex) {
        throw ex;
      } finally {
        connection.Close();
      }

      return null;
    }

    public static AddonCollection GetAllAddonsForProduct(Product product) {
      AddonCollection allAddons = new AddonCollection();
      SqlConnection connection = Connection.GetConnection();
      string selectStatement = $"SELECT a.id, a.name, a.description, a.price FROM DBO.Addons as a, " +
        $"DBO.ProductAddons as pa WHERE a.id = pa.addon_id AND pa.product_id = {product.Id}";
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

      try {
        connection.Open();
        SqlDataReader addonReader = selectCommand.ExecuteReader();
        while (addonReader.Read()) {
          Addon addon = new Addon();
          addon.Id = (int)addonReader["id"];
          addon.Name = (string)addonReader["name"];
          addon.Description = (string)addonReader["description"];
          addon.Price = Convert.ToDouble((decimal)addonReader["price"]);

          allAddons.Add(addon);
        }
      } catch (SqlException ex) {
        throw ex;
      } finally {
        connection.Close();
      }

      return allAddons;
    }
  }
}
