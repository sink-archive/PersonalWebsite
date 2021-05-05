<script>
 export let path;
 export let name;
</script>

<div class="card">
    <img src="/abstract_art/bitmap/{path}.png"
         class="image"
         alt="Preview of Artwork: '{name}'">
    <p class="name">{name}</p>
    <div class="buttons">
        <a href="/abstract_art/vector/{path}.svg"
           target="_blank"
           download
           class="button">SVG</a>
        <a href="/abstract_art/bitmap/{path}.png"
           target="_blank"
           download
           class="button">PNG</a>
    </div>
</div>

<style>
 .card {
     width: 18rem;
     margin: .5rem;
     border: 1px solid lightslategray;
     border-radius: .25rem;
     padding: .5rem;
 }

 .image {
     object-fit: contain;
     height: 10rem !important;
     display: block;
     margin-left: auto;
     margin-right: auto;
 }

 .buttons {
     display: flex;
 }

 .button {
     width: 100%;
     background: 0;
     border: 1px darkcyan solid;
     border-radius: .25rem;
     margin: .25rem;
     text-align: center;
     color: darkcyan;
 }

 .name {
     font-weight: lighter;
     font-size: 1.5em;
     margin: .5em 0;
 }
</style>
