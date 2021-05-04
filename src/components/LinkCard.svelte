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
</a>

<style>
.card {
	/* disable link colour for cards */
	color: unset !important;
	/* other stuffs */
	width: 15rem;
	height: 5rem;
	margin: .25rem;
	padding: .5rem;
	border: 1px solid #d0d0d0;
	border-radius: .25rem;

	text-align: left;
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
