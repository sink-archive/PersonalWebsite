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
.topbar {
    display: flex;
}
.topbar .left {
    float: left;
    flex: 1;
}
.topbar .right {
    float: right;
    margin-left: 4rem;
}
 /* Specific to this page :) */
 h1 {
     font-size: 3em;
     margin-top: .25rem;
 }
</style>
