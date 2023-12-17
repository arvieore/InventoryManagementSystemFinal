
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
    using System.Collections.Generic;
    
public partial class Products
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Products()
    {

        this.Cart = new HashSet<Cart>();

        this.HistoryTransaction = new HashSet<HistoryTransaction>();

    }


    public int productID { get; set; }

    public string product_Name { get; set; }

    public string product_Sku { get; set; }

    public string product_Quantity { get; set; }

    public Nullable<decimal> product_Price { get; set; }

    public string product_Description { get; set; }

    public int categoryID { get; set; }



    public virtual Category Category { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Cart> Cart { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<HistoryTransaction> HistoryTransaction { get; set; }

}

}