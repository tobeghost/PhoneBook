using MongoDB.Bson;

namespace PhoneBook.Domain
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntity
    {
        private string _id;

        protected BaseEntity()
        {
            _id = ObjectId.GenerateNewId().ToString();
        }

        public string Id
        {
            get { return _id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _id = ObjectId.GenerateNewId().ToString();
                else
                    _id = value;
            }
        }
    }
}