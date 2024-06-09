/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./**/*.razor",
        "./**/*.html",
        "./**/*.cshtml",
        "./**/*.razor.cs",
        "./**/*.js"
    ],
    theme: {
        extend: {
            transitionProperty: {
                'height': 'height',
                'spacing': 'margin, padding',
                animationDelay: {
                    275: '275ms',
                    5000: '5s',
                },
                animationDuration: {
                    2000: '2s',
                    'long': '10s',
                    'very-long': '20s',
                },
            },
        },
    },
    variants: {
        extend: {
            opacity: ['responsive', 'hover', 'focus', 'group-hover'],
            translate: ['responsive', 'hover', 'focus', 'group-hover'],
        },
    },
    plugins: [
        require('tailwindcss-animated'),
        require('@tailwindcss/forms'),
    ],
}

