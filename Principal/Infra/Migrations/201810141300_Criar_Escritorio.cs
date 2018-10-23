using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Migrations
{
    [Migration(201810141300)]
    public class _201810141300_Criar_Escritorio : Migration
    {
        public override void Down()
        {

        }

        public override void Up()
        {
            Create.Table("Escritorio")
                    .WithColumn("Id").AsInt32().PrimaryKey()
                    .WithColumn("Nome").AsString(200)
                    .WithColumn("CNPJ").AsString(200)
                    .WithColumn("CEP").AsString(200)
                    .WithColumn("Rua").AsString(200)
                    .WithColumn("Numero").AsString(200)
                    .WithColumn("Bairro").AsString(200)
                    .WithColumn("Cidade").AsString(200)
                    .WithColumn("UF").AsString(200)
                    .WithColumn("Complemento").AsString(200).Nullable()
                    .WithColumn("LCP").AsInt32().ForeignKey().Nullable()
                    .WithColumn("LCPNome").AsString(200).Nullable();

            Insert.IntoTable("Escritorio").Row(new Dictionary<string, object>() {
                {"Id", 1},
                {"Nome", "AIESEC BRASIL"},
                {"CNPJ", "48.605.307/0001-42"},
                {"CEP", "04.106-000"},
                {"Rua", "Rua Machado de Assis"},
                {"Numero", "252"},
                {"Bairro", "Vila Mariana"},
                {"Cidade", "São Paulo"},
                {"UF", "SP"},
                {"Complemento", ""}
            });
        }
    }
}
