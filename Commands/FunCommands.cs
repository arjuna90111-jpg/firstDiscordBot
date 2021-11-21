using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.Interactivity;
using DSharpPlus.Entities;
using System.Linq;
using DSharpPlus.Interactivity.Extensions;

namespace DiscordBot.Commands
{
    public class FunCommands:BaseCommandModule
    {
        [Command("ping")]
        [Description("返回訊息")]
        public async Task Ping(CommandContext ctx)
        {
           await ctx.Channel.SendMessageAsync("Pong!").ConfigureAwait(false);
        }

        [Command("add")]
        [Description("兩數相加")]
        public async Task Add(CommandContext ctx,
            [Description("第一個數字")] int numberOne,
            [Description("第二個數字")]int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne + numberTwo).ToString())
                .ConfigureAwait(false);
        }


        [Command("sub")]
        [Description("兩數相減")]
        public async Task Sub(CommandContext ctx,
            [Description("第一個數字")] int numberOne,
            [Description("第二個數字")]int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne - numberTwo).ToString())
                .ConfigureAwait(false);
        }


        [Command("mul")]
        [Description("兩數相乘")]
        public async Task Mul(CommandContext ctx,
           [Description("第一個數字")] int numberOne,
           [Description("第二個數字")] int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne * numberTwo).ToString())
                .ConfigureAwait(false);
        }


        [Command("div")]
        [Description("兩數相除")]
        public async Task Div(CommandContext ctx,
          [Description("第一個數字")] int numberOne,
          [Description("第二個數字")] int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne / numberTwo).ToString())
                .ConfigureAwait(false);
        }


        [Command("respondmessage")]
        [Description("回傳一樣的訊息")]
        public async Task RespondMessage(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(message.Result.Content);
        }

        [Command("respondreaction")]
        [Description("回傳表情符號")]
        public async Task RespondReaction(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForReactionAsync(x => x.Channel == ctx.Channel && x.User == ctx.User).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(message.Result.Emoji);
        }

        [Command("hello")]
        [Description("返回訊息")]
        public async Task SixFive(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("yooooooo").ConfigureAwait(false);
        }


        [Command("huh")]
        [Description("返回訊息")]
        public async Task Tommy(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("ayaya").ConfigureAwait(false);
        }




    }
}
