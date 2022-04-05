namespace ASP_MVC_Template_FW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mod_kolcsozo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kolcsonzok", "Nev", c => c.String(nullable: false));
            AlterColumn("dbo.Kolcsonzok", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kolcsonzok", "Email", c => c.String());
            AlterColumn("dbo.Kolcsonzok", "Nev", c => c.String());
        }
    }
}
