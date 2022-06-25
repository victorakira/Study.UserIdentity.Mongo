using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace Study.UserIdentity.Mongo.Models
{
    [CollectionName("Roles")]
    public class RoleModel : MongoIdentityRole<Guid>
    {
    }
}
