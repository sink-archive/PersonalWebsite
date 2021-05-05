<script>
    import GithubIcon from '../../components/GithubIcon.svelte';
    import Highlight  from 'svelte-highlight';
       import csharp from "svelte-highlight/src/languages/csharp";
    import "svelte-highlight/src/styles/base16-monokai.css";
</script>

<h1>Anilist4NET <GithubIcon repo="Anilist4Net" /></h1>

<p class="subtitle">Finally! An Anilist API lib for .NET that doesn't suck!</p>

<p>
    Anilist4NET is an easy to use API library for <a href="//anilist.co">Anilist</a>.
    To get started, download it from NuGet: <code>dotnet add package Anilist4Net</code>
</p>

<h3>Basic usage</h3>
<p>
    Let's get an anime from it's Anilist ID:
    <Highlight language={csharp} code="using System;
using Anilist4Net;
var client = new Client();
var anime = await client.GetMediaById(1);
Console.WriteLine($&quot;Name: &#123;anime.EnglishTitle&#125;&quot;); // Cowboy Bebop
Console.WriteLine($&quot;Episodes: &#123;anime.Episodes&#125;&quot;); // 26 episodes" />
    
    Cool! How about finding an anime more loosely, say just from it's name?
    <Highlight language={csharp} code="using System;
using Anilist4Net;
var client = new Client();
var anime = await client.GetMediaBySearch(&quot;カウボーイビバップ&quot;);
Console.WriteLine($&quot;ID: &#123;anime.Id&#125;&quot;);           // 1
Console.WriteLine($&quot;Year: &#123;anime.SeasonYear&#125;&quot;); // 1998" />
    
    You could also get an anime by it's ID on MyAnimeList, like this:
    <Highlight language={csharp} code="using System;
using Anilist4Net;
var client = new Client();
var anime = await client.GetMediaByMalId(21);
Console.WriteLine($&quot;Name: &#123;anime.EnglishTitle&#125;&quot;); // One Piece
Console.WriteLine($&quot;Anilist ID: &#123;anime.Id&#125;&quot;);     // 21 (same as MAL but ok)" />
</p>
