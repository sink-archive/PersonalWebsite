<script>
	export let showSubtitle = false;
	export let href;
</script>

<a {href} class="card">
	<div class="title">
		<slot name="title" />
	</div>
	{#if showSubtitle}
	<div class="subtitle">
		<slot name="subtitle" />	
	</div>
	{/if}
	<a {href}>Visit page</a>
</a>

<style>
.card {
	/* disable link colour for cards */
	--link-color: unset !important;
	/* general card styles */
	display: block;
	min-width: 15rem;
	flex: 1;
	margin: .25rem;
	padding: .5rem;
	border: 1px solid lightslategray;
	border-radius: .25rem;
}
</style>
