namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "AuthorID", c => c.Int());
            CreateIndex("dbo.Contents", "AuthorID");
            AddForeignKey("dbo.Contents", "AuthorID", "dbo.Authors", "AuthorID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Contents", new[] { "AuthorID" });
            DropColumn("dbo.Contents", "AuthorID");
        }
    }
}
