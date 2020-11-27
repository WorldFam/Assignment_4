using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignnment_4_API.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;

namespace Assignnment_4_API.Data.Impl
{
    public class SqliteAdultService : ICloudService

    {
    public AdultDbContext ctx;

    public SqliteAdultService(AdultDbContext ctx)
    {
        this.ctx = ctx;
    }

    public async Task<IList<Adult>> GetAdultAsync()
    {
        return await ctx.Adult.ToListAsync();
    }

    public async Task<Adult> AddAdultAsync(Adult adult)
    {
        EntityEntry<Adult> newlyAdded = await ctx.Adult.AddAsync(adult);
        await ctx.SaveChangesAsync();
        return newlyAdded.Entity;
    }

    public async Task RemoveAdultAsync(int adultId)
    {
        Adult toDelete = await ctx.Adult.FirstOrDefaultAsync(t => t.Id == adultId);
        if (toDelete != null)
        {
            ctx.Adult.Remove(toDelete);
            await ctx.SaveChangesAsync();
        }
    }

    public async Task<Adult> UpdateAdultAsync(Adult adult)
    {
        try
        {
            Adult toUpdate = await ctx.Adult.FirstAsync(t => t.Id == adult.Id);
            toUpdate.Age = adult.Age;
            toUpdate.Height = adult.Height;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.Sex = adult.Sex;
            toUpdate.Weight = adult.Weight;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.JobTitle = adult.JobTitle;
            ctx.Update(toUpdate);
            await ctx.SaveChangesAsync();
            return toUpdate;
        }
        catch (Exception e)
        {
          throw e;
        }
    }

    public async Task<Adult> GetAdultByIdAsync(int id)
    {
        return await ctx.Adult.FindAsync(id);
    }
    }
}