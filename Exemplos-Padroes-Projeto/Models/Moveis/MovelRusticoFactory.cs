using ExemplosPadrõesProjeto.Models.Moveis;
using ExemplosPadroesProjeto.Models.Moveis.Rustico;

namespace ExemplosPadroesProjeto.Models.Moveis
{
    public class MovelRusticoFactory : MovelAbstractFactory
    {
        protected override Armario CriarArmario()
        {
            return new ArmarioRustico();
        }

        protected override Cadeira CriarCadeira()
        {
            return new CadeiraRustica();
        }

        protected override Escrivaninha CriarEscrivaninha()
        {
            return new EscrivaninhaRustica();
        }

        protected override Mesa CriarMesa()
        {
            return new MesaRustica();
        }
    }
}
