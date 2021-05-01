<script>
		let border = "1px solid lightslategray";

		export let href;
		export let indent = 0;

		// ignore this pure spaghetti that makes this component work for a treeview-style list too
		let style = "";
		if (indent != 0) {
				style += `border-left: ${border}; border-top: ${border}; margin-top: -1px;`;
		}
		style += `margin-left: ${indent}rem`;
</script>

<li {style}><a {href}><slot/></a></li>

<style>
li {
		list-style-type: none;
		padding: .2rem .5rem;
		border-bottom: 1px solid lightslategray;
}
li:last-child {
		border-bottom: none;
}
</style>
