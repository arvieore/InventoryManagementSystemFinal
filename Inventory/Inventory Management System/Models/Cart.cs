
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
    
public partial class Cart
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Cart()
    {

        this.HistoryTransaction = new HashSet<HistoryTransaction>();

    }


    public int CartID { get; set; }

    public int productID { get; set; }

    public int categoryID { get; set; }

    public int user_ID { get; set; }

    public int OrderNo { get; set; }

    public int OrderQuantity { get; set; }

    public string customer_name { get; set; }

    public string customer_address { get; set; }

    public string Order_status { get; set; }

    public Nullable<System.DateTime> Order_Date { get; set; }



    public virtual Category Category { get; set; }

    public virtual Products Products { get; set; }

    public virtual Accounts Accounts { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<HistoryTransaction> HistoryTransaction { get; set; }

}

}
