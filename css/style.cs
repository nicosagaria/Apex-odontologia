/* Error: Can't find stylesheet to import.
 *   ,
 * 1 | @import '../base/variables ';
 *   |         ^^^^^^^^^^^^^^^^^^^^
 *   '
 *   scss\components\_header.scss 1:9  @import
 *   scss\style.scss 3:9               root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: "Error: Can't find stylesheet to import.\a   \2577 \a 1 \2502  @import '../base/variables ';\d\a   \2502          ^^^^^^^^^^^^^^^^^^^^\a   \2575 \a   scss\\components\\_header.scss 1:9  @import\a   scss\\style.scss 3:9               root stylesheet";
}
