using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Migrations
{
    [Migration(201810141816)]
    public class _201810141816_Criar_Testemunha : Migration
    {
        public override void Down()
        {

        }

        public override void Up()
        {
            Create.Table("Testemunha")
                    .WithColumn("Id").AsInt32().PrimaryKey()
                    .WithColumn("IdTestemunha1GV").AsInt32().Nullable()
                    .WithColumn("NomeTestemunha1GV").AsString(200).Nullable()
                    .WithColumn("IdTestemunha1GE").AsInt32().Nullable()
                    .WithColumn("NomeTestemunha1GE").AsString(200).Nullable()
                    .WithColumn("IdTestemunha1GT").AsInt32().Nullable()
                    .WithColumn("NomeTestemunha1GT").AsString(200).Nullable()
                    .WithColumn("IdTestemunha2GV").AsInt32().Nullable()
                    .WithColumn("NomeTestemunha2GV").AsString(200).Nullable()
                    .WithColumn("IdTestemunha2GE").AsInt32().Nullable()
                    .WithColumn("NomeTestemunha2GE").AsString(200).Nullable()
                    .WithColumn("IdTestemunha2GT").AsInt32().Nullable()
                    .WithColumn("NomeTestemunha2GT").AsString(200).Nullable();

            Insert.IntoTable("Testemunha").Row(new Dictionary<string, object>() {
                {"Id", 1},
                {"IdTestemunha1GV", null},
                {"NomeTestemunha1GV", ""},
                {"IdTestemunha1GE", null},
                {"NomeTestemunha1GE", ""},
                {"IdTestemunha1GT", null},
                {"NomeTestemunha1GT", ""},
                {"IdTestemunha2GV", null},
                {"NomeTestemunha2GV", ""},
                {"IdTestemunha2GE", null},
                {"NomeTestemunha2GE", ""},
                {"IdTestemunha2GT", null},
                {"NomeTestemunha2GT", ""}
            });
        }
    }
}
