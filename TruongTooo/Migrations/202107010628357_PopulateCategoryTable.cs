namespace TruongTooo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Categories(ID,NAME) VALUES (1,'Development')");
            Sql("Insert Into Categories(ID,NAME) VALUES (2,'Business')");
            Sql("Insert Into Categories(ID,NAME) VALUES (3,'Marketing')");
            

        }
        
        public override void Down()
        {
        }
    }
}
