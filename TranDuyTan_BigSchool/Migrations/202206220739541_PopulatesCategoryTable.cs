namespace TranDuyTan_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatesCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1,'KINH TE')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2,'KINH DOANH')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3,'CONG NGHE THING TIN')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (4,'TAM LY HOC')");
        }
        
        public override void Down()
        {
        }
    }
}
