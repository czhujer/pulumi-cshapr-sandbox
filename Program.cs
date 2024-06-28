using Pulumi;

using System.Linq;
using System.Threading.Tasks;

class Program
{
    static Task<int> Main() => Pulumi.Deployment.RunAsync<MyStack>();
}
