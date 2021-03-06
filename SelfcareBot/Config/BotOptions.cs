using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SelfcareBot.Config
{
    public class BotOptions
    {
        [Required] public IList<string> CommandPrefixes { get; init; } = new List<string>();

        [Required] [AllowNull] public string DiscordToken { get; init; }
    }
}