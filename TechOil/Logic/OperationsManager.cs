using Microsoft.EntityFrameworkCore.Metadata;
using TechOil.Services;

namespace TechOil.Logic;

public class OperationsManager
{
    private readonly IUnitOfWork _unitOfWorkService;

    public OperationsManager(IUnitOfWork unitOfWork)
    {
        _unitOfWorkService = unitOfWork;
    }
    
    /* Operacion de ejemplo
    public async Task Deposit(int uno, int dos)
    {
        uno += dos;
        await _unitOfWorkService.RepositorioAUsar.FuncionAUsar(AtributosAUsar)
    }
    */
}