namespace Theorems.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Theorems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Content = c.String(),
                        Proof = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TheoremAuthors",
                c => new
                    {
                        Theorem_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Theorem_Id, t.Author_Id })
                .ForeignKey("dbo.Theorems", t => t.Theorem_Id, cascadeDelete: true)
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Theorem_Id)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TheoremAuthors", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.TheoremAuthors", "Theorem_Id", "dbo.Theorems");
            DropIndex("dbo.TheoremAuthors", new[] { "Author_Id" });
            DropIndex("dbo.TheoremAuthors", new[] { "Theorem_Id" });
            DropTable("dbo.TheoremAuthors");
            DropTable("dbo.Theorems");
            DropTable("dbo.Authors");
        }
    }
}
