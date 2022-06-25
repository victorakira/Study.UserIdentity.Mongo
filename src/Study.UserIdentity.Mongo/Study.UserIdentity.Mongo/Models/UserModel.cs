using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace Study.UserIdentity.Mongo.Models
{
    [CollectionName("User")]
    public class UserModel : MongoIdentityUser<Guid>
    {
    }
}
