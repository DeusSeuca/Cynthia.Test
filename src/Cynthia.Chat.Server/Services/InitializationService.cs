using Autofac;
using Cynthia.Chat.Server.Attributes;

namespace Cynthia.Chat.Server.Services
{
    [Singleton]
    public class InitializationService
    {
        public MongoService Mongo { get; set; }
        public void Start()
        {
            Mongo.InitData();
            Mongo.AutoSaveData();
        }
    }
}