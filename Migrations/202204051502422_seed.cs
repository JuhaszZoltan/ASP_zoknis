namespace ASP_MVC_Template_FW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO zoknik VALUES ('cat', 20, 40, 2, 'cat.png');");
            Sql("INSERT INTO zoknik VALUES ('dog', 9, 62, 6, 'dog.png');");
            Sql("INSERT INTO zoknik VALUES ('flamingo', 0, 178, 11, 'flamingo.png');");
            Sql("INSERT INTO zoknik VALUES ('hotdog', 11, 90, 5, 'hotdog.png');");
            Sql("INSERT INTO zoknik VALUES ('monkey', 7, 7, 32, 'monkey.png');");

            Sql("INSERT INTO kolcsonzok VALUES ('Beviz Elek', 'elekvok@citromail.hu', 7);");
            Sql("INSERT INTO kolcsonzok VALUES ('Para Zita', 'peezee@freemail.hu', 104);");
            Sql("INSERT INTO kolcsonzok VALUES ('Ultra Viola', 'ultrav@gerillamail.com', 9);");
        }
        
        public override void Down()
        {
        }
    }
}
