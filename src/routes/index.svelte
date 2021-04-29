<script>
	import IndexTopBar from '../components/IndexTopBar.svelte';
	import LinkCard    from '../components/LinkCard.svelte';

	let importantLinks = [
		{
			title: 'Reggie',
			subtitle: 'An awesome regex tool',
			link: 'project/reggie'
		},
		{
			title: 'Discord client modding & themes',
			link: 'project/discordmodding'
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

<div class="card-container">
	{#each importantLinks as link}
	<LinkCard showSubtitle="{link.subtitle}" href="{link.link}">
		<span slot="title">{link.title}</span>
		<span slot="subtitle">{link.subtitle}</span>
	</LinkCard>
	{/each}
</div>



<style>
.card-container {
	display: flex;
	flex-wrap: wrap;
}
</style>
