<template>
<div class="editor">
  <editor-content :editor="editor" />
  <button @click="show">click</button>
</div>

</template>


<script>
export default {
  name: "Editor"
}
</script>

<script setup>
import { useEditor, EditorContent } from '@tiptap/vue-3'
import StarterKit from '@tiptap/starter-kit'

const editor = useEditor({
  content: '<p>I’m running Tiptap with Vue.js. 🎉</p>',
  extensions: [
    StarterKit,
  ],
})

const show = () => {
  console.log(editor.value.getJSON())
}
</script>

<style scoped lang="scss">
.editor {
  min-height: 400px;
}
.editor::-webkit-scrollbar-thumb {
    background-image: linear-gradient(180deg, #D0368A 0%, #708AD4 99%);
    box-shadow: inset 2px 2px 5px 0 rgba(#fff, 0.5);
    border-radius: 100px;
}
</style>