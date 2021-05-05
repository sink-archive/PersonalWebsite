<svelte:head>
    <link href="/styles.css" rel="stylesheet" />
    <title>Cain's site</title>
</svelte:head>

<nav>
    <a href="/">Home</a>
    <a href="rhythm">Rhythm Games</a>
    <a href="links">Links</a>
</nav>

<main>
    <div class="container">
        <slot/>
    </div>
</main>

<style>
nav {
    height: 1.5rem;
    padding: .5rem;
    padding-top: 0;
    border-bottom: 1px solid grey;
    text-align: center;
}

nav a {
    /*
    --link-spacing: 2rem;
    margin-left: calc(var(--link-spacing) / 2);
    margin-right: calc(var(--link-spacing) / 2);
 */

    display: inline-block;
    width: 9rem;
}
</style>
