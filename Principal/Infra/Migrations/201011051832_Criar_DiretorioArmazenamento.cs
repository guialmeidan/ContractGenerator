using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Migrations
{
    [Migration(201011051832)]
    public class _201011051832_Criar_DiretorioArmazenamento : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Create.Table("DiretorioArmazenamento")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("Caminho").AsString(200);

            Insert.IntoTable("DiretorioArmazenamento").Row(new Dictionary<string, object>() {
                {"Id", 1},
                {"Caminho", caminho}
            });
        }
    }
}
