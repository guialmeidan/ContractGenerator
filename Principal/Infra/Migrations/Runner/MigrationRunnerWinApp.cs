using FluentMigrator.Runner;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.Processors;
using Principal.Infra.DatabaseFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra
{
    public class MigrationRunnerWinApp : IMigrationWinAppRunner
    {
        public MigrationRunnerWinApp(IDatabaseAdapter databaseAdapter)
        {
            DatabaseAdapter = databaseAdapter;
            this.ConnectionString = databaseAdapter.ConnectionString;
        }

        public IDatabaseAdapter DatabaseAdapter { get; }
        public string ConnectionString { get; }

        public void Execute()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            Announcer announcer = new TextWriterAnnouncer(s => System.Diagnostics.Debug.WriteLine(s));

            IRunnerContext migrationContext = new RunnerContext(announcer);

            var assembly = DatabaseAdapter.GetType().Assembly;

            var options = new ProcessorOptions
            {
                PreviewOnly = false,
                Timeout = 60
            };

            var factory = new FluentMigrator.Runner.Processors.SQLite.SQLiteProcessorFactory();

            var processor = factory.Create(ConnectionString, announcer, options);
            var runner = new MigrationRunner(assembly, migrationContext, processor);
            runner.MigrateUp();
        }
    }
}
