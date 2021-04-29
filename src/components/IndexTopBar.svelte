<script>
	import Image from './ProfileImage.svelte';
</script>

<div class="topbar">
	<div class="left">
		<h1><slot name="title" /></h1>
		<p class="subtitle"><slot name="subtitle" /></p>
	</div>
	<div class="right">
		<Image />
	</div>
</div>


<style>
.subtitle {
	font-size: 1.3rem;
}

.topbar {
	display: flex;
}
.topbar .left {
	float: left;
}
.topbar .right {
	float: right;
	margin-left: .5rem;
}
</style>
