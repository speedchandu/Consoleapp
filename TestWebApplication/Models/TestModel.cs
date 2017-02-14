namespace TestWebApplication.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class TestModel : DbContext
    {
        // Your context has been configured to use a 'TestModel' connection string from your application's
        // configuration file (App.config or Web.config). By default, this connection string targets the
        // 'TestWebApplication.Models.TestModel' database on your LocalDb instance.
        //
        // If you wish to target a different database and/or database provider, modify the 'TestModel'
        // connection string in the application configuration file.
        public TestModel()
            : base("name=TestModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


    }

    public class Contact
    {
        [Required(ErrorMessage ="This is required field.")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Contact_Number { get; set; }
        public string Address { get; set; }
    }

    public class Order
    {
        public int id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int Product_ID { get; set; }
        [Required]
        public int User_ID { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int Status { get; set; }

    }


    public class Category
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public string Category_desc { get; set; }
    }


}










