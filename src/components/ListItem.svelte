<script>
    export let href;
    export let indent = 0;
</script>

<li style="margin-left: calc({indent}rem - 1px)"><a {href}><slot/></a></li>

<style>
li {
    list-style-type: none;
    padding: .2rem .5rem;
    border: 1px solid lightslategray;
    margin-top: -1px;
}

li:first-child {
    border-radius: .25rem .25rem 0 0;
    margin-top: 0;
}

li:last-child {
    border-radius: 0 0 .25rem .25rem;
}
</style>
