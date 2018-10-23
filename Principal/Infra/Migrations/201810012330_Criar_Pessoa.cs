using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Migrations
{
    [Migration(201810012330)]
    public class _201810012330_Create_Table_People : Migration
    {
        public override void Down()
        {

        }

        public override void Up()
        {

            Create.Table("Pessoa")
                    .WithColumn("Id").AsInt32().PrimaryKey()
                    .WithColumn("Nome").AsString(200)
                    .WithColumn("Sobrenome").AsString(200)
                    .WithColumn("Nacionalidade").AsString(200)
                    .WithColumn("EstadoCivil").AsString(200)
                    .WithColumn("Profissao").AsString(200)
                    .WithColumn("TipoDocumento").AsInt32()
                    .WithColumn("NumeroDocumento").AsString(200)
                    .WithColumn("OrgaoExpedidor").AsString(200).Nullable()
                    .WithColumn("UFDocumento").AsString(200).Nullable()
                    .WithColumn("CPF").AsString(200)
                    .WithColumn("Email").AsString(200)
                    .WithColumn("CEP").AsString(200)
                    .WithColumn("Rua").AsString(200)
                    .WithColumn("Numero").AsString(200)
                    .WithColumn("Bairro").AsString(200)
                    .WithColumn("Cidade").AsString(200)
                    .WithColumn("UFEndereco").AsString(200)
                    .WithColumn("Complemento").AsString(200).Nullable();
        }
    }
}
