<script>
		export let href;
</script>

<li><a {href}><slot/></a></li>

<style>
li {
		list-style-type: none;
		padding: .2rem .5rem;
		border-bottom: 1px solid lightslategray;
}
a:last-child li {
		border-bottom: none;
}
</style>
