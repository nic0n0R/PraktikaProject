using System.Data;

namespace PraktikaProject.CRUD.Create
{
    public interface IDataWorker
    {
        void InsertDataIntoTable(string table, string[] args);
        DataTable RefreshDataInGridView(string table);
        void RemoveRowFromTableById(string table, int id);
        DataTable ExecuteUserCommand(string command);

    }
}
