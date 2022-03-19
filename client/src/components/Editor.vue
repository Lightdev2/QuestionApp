<template>
<div>
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