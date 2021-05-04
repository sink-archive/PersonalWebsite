<script>
	import IndexTopBar from '../components/IndexTopBar.svelte';
	import LinkCard    from '../components/LinkCard.svelte';
	import ListItem    from '../components/ListItem.svelte';

	let importantLinks = [
		{
			title: 'Reggie',
			subtitle: 'An awesome regex tool',
			link: 'project/reggie'
		},
		{
			title: 'Gord',
			subtitle: 'Advanced terminal Discord client',
			link: 'project/gord'
		},
		{
			title: 'ExType',
			subtitle: 'Next generation type conversion',
			link: 'project/extype'
		},
		{
			title: 'Anilist4NET',
			subtitle: 'Finally! A good Anilist client!',
			link: 'project/anilist4net'
		},
		{
			title: 'Discord client modding & themes',
			link: 'project/discord-modding'
		},
		{
			title: 'C# stuff',
			subtitle: '...including PGP!',
			link: 'csharp'
		},
		{
			title: 'Some images idk',
			link: 'gallery'
		},
		{
			title: 'A GUI for youtube-dl',
			link: 'project/ytdl-gui'
		}
	];
</script>

<IndexTopBar>
	<span slot="title">
		Cain Atkinson's site
	</span>
	<span slot="subtitle">
		Welcome! This is the place for all my random stuff, including projects and random articles / rants.
	</span>
</IndexTopBar>


<h2>More important stuff</h2>
<div class="card-container">
	{#each importantLinks as link}
	<LinkCard showSubtitle="{link.subtitle}" href="{link.link}">
		<span slot="title">{link.title}</span>
		<span slot="subtitle">{link.subtitle}</span>
	</LinkCard>
	{/each}
</div>

<h2>Stuff I care significantly less about</h2>
<ul class="list">
	<ListItem href="feature/can-i-jailbreak">Can I jailbreak? (visit on your phone)</ListItem>
	<ListItem href="//routinehub.co/user/Yellowsink">iOS Siri Shortcuts</ListItem>
	<ListItem href="article/jailbreak">Cringy jailbreaking article</ListItem>
	<ListItem href="feature/plugins">Audio Plugins</ListItem>
	<ListItem href="//cainssharptools.readthedocs.io">An old .NET library</ListItem>
	<ListItem href="project/run-pp">Run++ - a replacement for the Windows run dialog</ListItem>
	<ListItem href="duke">Duke Nukem 3D stuff</ListItem>
	<ListItem href="project/source-map-installer">Map installer for Source engine games</ListItem>
	<ListItem href="project/unity">My Unity stuff</ListItem>
	<ListItem href="article/powerpoint">Some cool stuff in Powerpoint</ListItem>
	<ListItem href="article/chromeos">Chrome OS idk anymore</ListItem>
	<ListItem href="article/python">Me hating Python a little</ListItem>
	<ListItem href="article/manjaro">Cringe person calls Arch stable</ListItem>
</ul>

<style>
.card-container {
	display: flex;
	flex-wrap: wrap;
 }
</style>
