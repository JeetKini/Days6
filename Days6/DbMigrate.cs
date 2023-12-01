using System;

namespace Days6
{
    class DbMigrate {
        private readonly ILogger logger;

        public DbMigrate(ILogger logger)
        {
            this.logger = logger;
        }
        public void Migrate() {

            logger.logInfo("Migration Started {0}" + DateTime.Now);

            logger.logInfo("Migration Finished {0}"+ DateTime.Now);
          //  Console.WriteLine("Migration Finished {0}", DateTime.Now);
        }
    }
    }

