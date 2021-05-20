<svelte:head>
    <link href="/styles.css" rel="stylesheet" />
    <title>Cain's site</title>

    <!-- Favicon etc -->
    <link rel="apple-touch-icon" sizes="180x180" href="/apple-touch-icon.png">
    <link rel="icon" type="image/png" sizes="32x32" href="/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="/favicon-16x16.png">
    <link rel="manifest" href="/site.webmanifest">
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
