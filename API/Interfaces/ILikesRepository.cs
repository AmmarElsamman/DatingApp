using System;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces;

public interface ILikesRepository
{
    // Get individual user like 
    // we make it optional just in case it's not found in our database
    Task<UserLike?> GetUserLike(int sourceUserId, int targetUserId);

    // we need to give the options (users they liked / users that liked them / mutual likes)
    Task<PagedList<MemberDto>> GetUserLikes(LikesParams likesParams);

    // used to display on the member cards which users they liked 
    Task<IEnumerable<int>> GetCurrentUserLikeIds(int currentUserId);

    void DeleteLike(UserLike like);

    void AddLike(UserLike like);

    Task<bool> SaveChanges();


}
