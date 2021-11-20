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
        [Description("Return Message")]
        public async Task Ping(CommandContext ctx)
        {
           await ctx.Channel.SendMessageAsync("Pong!").ConfigureAwait(false);
        }

        [Command("add")]
        [Description("Adds two numbers together")]
        public async Task Add(CommandContext ctx,
            [Description("First Number")] int numberOne,
            [Description("Second Number")]int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne + numberTwo).ToString())
                .ConfigureAwait(false);
        }


        [Command("sub")]
        [Description("Subs two numbers together")]
        public async Task Sub(CommandContext ctx,
            [Description("First Number")] int numberOne,
            [Description("Second Number")]int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne - numberTwo).ToString())
                .ConfigureAwait(false);
        }


        [Command("mul")]
        [Description("Subs two numbers together")]
        public async Task Mul(CommandContext ctx,
           [Description("First Number")] int numberOne,
           [Description("Second Number")] int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne * numberTwo).ToString())
                .ConfigureAwait(false);
        }


        [Command("div")]
        [Description("Subs two numbers together")]
        public async Task Div(CommandContext ctx,
          [Description("First Number")] int numberOne,
          [Description("Second Number")] int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne / numberTwo).ToString())
                .ConfigureAwait(false);
        }


        [Command("respondmessage")]
        public async Task RespondMessage(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(message.Result.Content);
        }

        [Command("respondreaction")]
        public async Task RespondReaction(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForReactionAsync(x => x.Channel == ctx.Channel && x.User == ctx.User).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(message.Result.Emoji);
        }

        [Command("hello")]
        [Description("Return Message")]
        public async Task SixFive(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("yooooooo").ConfigureAwait(false);
        }


        [Command("huh")]
        [Description("Return Message")]
        public async Task Tommy(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("ayaya").ConfigureAwait(false);
        }




    }
}
