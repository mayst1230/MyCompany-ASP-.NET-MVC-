using Company.Domain.Repos.Interfaces;

namespace Company.Domain
{
    public class DataManager
    {
        public ITextFieldsStorage TextFields { get; set; }
        public IServiceItemsStorage ServiceItems { get; set; }

        public DataManager(ITextFieldsStorage textFieldsStorage, IServiceItemsStorage serviceFieldsStorage)
        {
            TextFields = textFieldsStorage;
            ServiceItems = serviceFieldsStorage;
        }
    }
}
