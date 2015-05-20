using StructureMap;
using System;

namespace Example11
{
    public class Program
    {
        private const int USERID = 5;

        public static void Main(string[] args)
        {
            var container = new Container();
            container.Configure(x => x.AddRegistry<ExampleRegistry>());

            var repository = container.GetInstance<IRepository<User>>();
            repository.Add(new User { ID = USERID, Name = "In memory repository" });

            var localFoo = container.GetInstance<IFoo>();

            Console.WriteLine(localFoo.GetMessageForUser(USERID));

            Console.ReadLine();
        }
    }
}
