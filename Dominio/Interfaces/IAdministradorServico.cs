using DesafioDotnet.Dominio.Entidades;
using DesafioDotnet.DTOs;

namespace DesafioDotnet.Dominio.interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador Incluir(Administrador administrador);
    List<Administrador> Todos(int? pagina);
    Administrador? BuscaPorId(int id);
}