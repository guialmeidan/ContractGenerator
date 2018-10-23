using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.Infra.Migrations
{
    [Migration(201810012310)]
    public class _201810012310_Criar_Banco : Migration
    {
        public override void Down()
        {

        }

        public override void Up()
        {
            new DatabaseFactory.DatabaseAdapters.DatabaseAdapterSQLite().CreateDatabase();

        }
    }
}
