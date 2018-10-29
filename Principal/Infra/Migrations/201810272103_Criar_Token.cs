using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Migrations
{
    [Migration(201810272103)]
    public class _201810272103_Criar_Token : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("TokenPublico")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("Token").AsString(200);                  

            Insert.IntoTable("TokenPublico").Row(new Dictionary<string, object>() {
                {"Id", 1},
                {"Token", "e316ebe109dd84ed16734e5161a2d236d0a7e6daf499941f7c110078e3c75493"}
            });
        }
    }
}
