var ctx = new MyContext();

ctx.AddRange(new[]
{
    new MyEntity { KeyCol1 = "a" },
    new MyEntity { KeyCol1 = "b" },
    new MyEntity { KeyCol1 = "c" },
    new MyEntity { KeyCol1 = "d" },
});

await ctx.SaveChangesAsync();
