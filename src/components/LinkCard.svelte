<script>
	export let showSubtitle = false;
	export let href;
</script>

<a {href} class="card">
	<div class="main">
		<div class="title">
			<slot name="title" />
		</div>
		{#if showSubtitle}
		<div class="card-subtitle">
			<slot name="subtitle" />	
		</div>
		{/if}
	</div>
	<a {href}>Visit page</a>
</a>

<style>
.card {
	/* disable link colour for cards */
	--link-color: unset !important;
	/* layout crap */
	display: flex;
	flex-flow: column nowrap;
	/* other stuffs */
	min-width: 15rem;
	flex: 1;
	margin: .25rem;
	padding: .5rem;
	border: 1px solid lightslategray;
	border-radius: .25rem;

	text-align: left;
}

.main {
	flex: 1;
}

.card a {
	width: max-content;
}

/* make the stuff inside look right */
.title {
	font-size: 1.25em;
}

.card-subtitle {
	font-weight: bold;
}
</style>
