using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Notifications
{
    public class Notificacao
    {
        public string Mensagem { get; }

        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
