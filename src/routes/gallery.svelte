<script>
    import VectorCard from '../components/VectorCard.svelte';
</script>

<h1>Some vector images ig</h1>
<img src="/abstract_art/bitmap/avatar/avatar_classic.jpeg"
     style="width:7rem;height:7rem;margin-left:1rem;"
     alt="My old Profile Picture"
     align="right">

<p class="subtitle">
    Inspired by this image, which was my profile pic from 2014(ish)
    to the beginning of July, 2020. It was the basis for my new set
    of profile pictures, which are currently in use.
    Check the homepage to see my current Gravatar.:
    <br />
    Oh and yeah I made some other random patterns of triangles and squares.
    IDK why.
</p>

<div class="container">
    <VectorCard path="avatar/avatar" name="Main avatar" />
    <VectorCard path="avatar/avatar_dark" name="Dark avatar" />
    <VectorCard path="avatar/avatar_contrast" name="High Contrast avatar" />
    <VectorCard path="abstract-1" name="IDK 1" />
    <VectorCard path="abstract-2" name="IDK 2" />
    <VectorCard path="abstract-3" name="IDK 3" />
</div>


<style>
 .container {
     display: flex;
     flex-flow: row wrap;
     justify-content: space-evenly;

     margin-top: 2.5rem;
 }
</style>
