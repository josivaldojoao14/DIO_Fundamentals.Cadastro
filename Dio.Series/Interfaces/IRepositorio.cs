using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Interfaces
{
    // <T> é um tipo genérico, ele será substituido por qualquer classe dentro do repositório
    // Nesse caso, o T está sendo substituido pela classe "Serie"
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}
