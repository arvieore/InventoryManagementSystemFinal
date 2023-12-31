﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Inventory_Management_System.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class DB_InventoryEntities : DbContext
{
    public DB_InventoryEntities()
        : base("name=DB_InventoryEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Accounts> Accounts { get; set; }

    public virtual DbSet<Category> Category { get; set; }

    public virtual DbSet<Products> Products { get; set; }

    public virtual DbSet<Role> Role { get; set; }

    public virtual DbSet<Cart> Cart { get; set; }

    public virtual DbSet<vw_LastOrderNumber> vw_LastOrderNumber { get; set; }

    public virtual DbSet<vw_PendingOrders> vw_PendingOrders { get; set; }

    public virtual DbSet<HistoryTransaction> HistoryTransaction { get; set; }

    public virtual DbSet<vw_Transaction_History> vw_Transaction_History { get; set; }

    public virtual DbSet<vw_SelectProducts> vw_SelectProducts { get; set; }

    public virtual DbSet<vw_BestSeller> vw_BestSeller { get; set; }


    public virtual ObjectResult<sp_ValidateAccount_Result> sp_ValidateAccount(string user_name, string user_password)
    {

        var user_nameParameter = user_name != null ?
            new ObjectParameter("user_name", user_name) :
            new ObjectParameter("user_name", typeof(string));


        var user_passwordParameter = user_password != null ?
            new ObjectParameter("user_password", user_password) :
            new ObjectParameter("user_password", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ValidateAccount_Result>("sp_ValidateAccount", user_nameParameter, user_passwordParameter);
    }


    public virtual int sp_AddNewProduct(string categoryName, string productName, string product_sku, string product_quantity, Nullable<decimal> product_price, string product_description)
    {

        var categoryNameParameter = categoryName != null ?
            new ObjectParameter("CategoryName", categoryName) :
            new ObjectParameter("CategoryName", typeof(string));


        var productNameParameter = productName != null ?
            new ObjectParameter("productName", productName) :
            new ObjectParameter("productName", typeof(string));


        var product_skuParameter = product_sku != null ?
            new ObjectParameter("product_sku", product_sku) :
            new ObjectParameter("product_sku", typeof(string));


        var product_quantityParameter = product_quantity != null ?
            new ObjectParameter("product_quantity", product_quantity) :
            new ObjectParameter("product_quantity", typeof(string));


        var product_priceParameter = product_price.HasValue ?
            new ObjectParameter("product_price", product_price) :
            new ObjectParameter("product_price", typeof(decimal));


        var product_descriptionParameter = product_description != null ?
            new ObjectParameter("product_description", product_description) :
            new ObjectParameter("product_description", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddNewProduct", categoryNameParameter, productNameParameter, product_skuParameter, product_quantityParameter, product_priceParameter, product_descriptionParameter);
    }


    public virtual ObjectResult<sp_CategoryFilter_Result> sp_CategoryFilter(string categoryFiltered)
    {

        var categoryFilteredParameter = categoryFiltered != null ?
            new ObjectParameter("CategoryFiltered", categoryFiltered) :
            new ObjectParameter("CategoryFiltered", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CategoryFilter_Result>("sp_CategoryFilter", categoryFilteredParameter);
    }


    public virtual int sp_AddAccount(string firstname, string lastname, string email, string phone, string gender, Nullable<System.DateTime> birthdate, string position, string password, string address)
    {

        var firstnameParameter = firstname != null ?
            new ObjectParameter("firstname", firstname) :
            new ObjectParameter("firstname", typeof(string));


        var lastnameParameter = lastname != null ?
            new ObjectParameter("lastname", lastname) :
            new ObjectParameter("lastname", typeof(string));


        var emailParameter = email != null ?
            new ObjectParameter("email", email) :
            new ObjectParameter("email", typeof(string));


        var phoneParameter = phone != null ?
            new ObjectParameter("phone", phone) :
            new ObjectParameter("phone", typeof(string));


        var genderParameter = gender != null ?
            new ObjectParameter("gender", gender) :
            new ObjectParameter("gender", typeof(string));


        var birthdateParameter = birthdate.HasValue ?
            new ObjectParameter("birthdate", birthdate) :
            new ObjectParameter("birthdate", typeof(System.DateTime));


        var positionParameter = position != null ?
            new ObjectParameter("position", position) :
            new ObjectParameter("position", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var addressParameter = address != null ?
            new ObjectParameter("address", address) :
            new ObjectParameter("address", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddAccount", firstnameParameter, lastnameParameter, emailParameter, phoneParameter, genderParameter, birthdateParameter, positionParameter, passwordParameter, addressParameter);
    }


    public virtual ObjectResult<sp_AccountFilter_Result> sp_AccountFilter(string accountFiltered)
    {

        var accountFilteredParameter = accountFiltered != null ?
            new ObjectParameter("AccountFiltered", accountFiltered) :
            new ObjectParameter("AccountFiltered", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_AccountFilter_Result>("sp_AccountFilter", accountFilteredParameter);
    }


    public virtual ObjectResult<sp_SelectProduct_Result> sp_SelectProduct()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SelectProduct_Result>("sp_SelectProduct");
    }


    public virtual ObjectResult<sp_SelectCategory1_Result> sp_SelectCategory()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SelectCategory1_Result>("sp_SelectCategory");
    }


    public virtual ObjectResult<sp_OrderDisplay_Result> sp_OrderDisplay(Nullable<int> orderNo)
    {

        var orderNoParameter = orderNo.HasValue ?
            new ObjectParameter("orderNo", orderNo) :
            new ObjectParameter("orderNo", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_OrderDisplay_Result>("sp_OrderDisplay", orderNoParameter);
    }


    public virtual ObjectResult<sp_CartCategoryFilter_Result> sp_CartCategoryFilter(string categoryFiltered)
    {

        var categoryFilteredParameter = categoryFiltered != null ?
            new ObjectParameter("CategoryFiltered", categoryFiltered) :
            new ObjectParameter("CategoryFiltered", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CartCategoryFilter_Result>("sp_CartCategoryFilter", categoryFilteredParameter);
    }

}

}

