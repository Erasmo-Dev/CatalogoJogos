using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.VewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Service
{
    public interface IJogoService
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
