using MyMarket.Domain.Repositories.Abstract;

namespace MyMarket.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IStoresrepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IStoresrepository serviceItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
