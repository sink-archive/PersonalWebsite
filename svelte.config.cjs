const preprocess = require('svelte-preprocess');

/** @type {import('@sveltejs/kit').Config} */
module.exports = {
	// Consult https://github.com/sveltejs/svelte-preprocess
	// for more information about preprocessors
	preprocess: preprocess(),

	kit: {
		// hydrate the <div id="svelte"> element in src/app.html
		target: '#svelte',

		vite: {
      optimizeDeps: {
        include: [
          "highlight.js/lib/core.js",
          "highlight.js/lib/languages/bash.js",
          "highlight.js/lib/languages/css.js",
          "highlight.js/lib/languages/javascript.js",
          "highlight.js/lib/languages/xml.js",
        ]
      }
    }
	}
};
